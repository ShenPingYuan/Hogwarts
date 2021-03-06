﻿using Hogwarts.Core;
using Hogwarts.DB.Model;
using Hogwarts.IRepository;
using Hogwarts.View.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly RoleManager<ApplicationIdentityRole> _roleManager;
        private readonly ICourseManager _courseManager;
        public AccountController(SignInManager<ApplicationIdentityUser> signInManager,
            ICourseManager courseManager,
            UserManager<ApplicationIdentityUser> userManager,
            RoleManager<ApplicationIdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _courseManager = courseManager;
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginView)
        {
            if (userLoginView == null)
            {
                //return View("Login",userLoginView);
                return JsonHelper.StandardJsonResult(1, 0, "数据上传失败", new List<object> { });
            }
            if (userLoginView.UserName == null || userLoginView.Password == null)
            {
                //return View("Login", userLoginView);
                return JsonHelper.StandardJsonResult(1, 0, "用户名或密码上传失败", new List<object> { });
            }
            var user = await _userManager.FindByNameAsync(userLoginView.UserName);
            if (user == null)
            {
                //return View("Login", userLoginView);
                return JsonHelper.StandardJsonResult(1, 0, "用户不存在", new List<object>());
            }
            var result = await _signInManager.PasswordSignInAsync(user, userLoginView.Password, false, false);
            if (result.Succeeded)
            {
                //return RedirectToAction("Index", "Home");
                return JsonHelper.StandardJsonResult(0, 0, "登陆成功", new List<object>());
            }
            //return View("Login", userLoginView);
            return JsonHelper.StandardJsonResult(1, 0, "密码错误", new List<object>());
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        public IActionResult Register()
        {
            return View();
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RegisterApi(UserLoginViewModel viewModel)
        {
            if (viewModel == null)
            {
                return JsonHelper.StandardJsonResult(1, 0, "数据上传失败", new List<object> { });
            }
            if (viewModel.UserName == null || viewModel.Password == null)
            {
                return JsonHelper.StandardJsonResult(1, 0, "用户名或密码上传失败", new List<object> { });
            }
            var identityUser = await _userManager.FindByNameAsync(viewModel.UserName);
            Teacher teacher = new Teacher();
            if (identityUser == null)
            {
                identityUser = new ApplicationIdentityUser
                {
                    UserName = viewModel.UserName,
                    Teacher = teacher,
                };
                var result = await _userManager.CreateAsync(identityUser, viewModel.Password);
                if (result.Succeeded)
                {
                    return JsonHelper.StandardJsonResult(0, 0, "注册成功", new List<object> { });
                }
                else
                {
                    return JsonHelper.StandardJsonResult(1, 0, "注册失败", new List<object> { });
                }
            }
            else
            {
                return JsonHelper.StandardJsonResult(1, 0, "用户已经存在", new List<object> { });
            }
        }
        public async Task<IActionResult> LogOutApi()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        [HttpGet]
        public IActionResult UserList()
        {
            return View();
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        public async Task<IActionResult> Users()
        {
            var users = await _userManager.Users.Select(x => new
            {
                x.UserName,
                RealName = x.Teacher.TName,
                x.Teacher.EnglishName,
                x.Teacher.Sex,
                x.RoleName
            }).ToListAsync();
            if (users != null)
            {
                List<UserListInfoViewModel> userInfoViews = new List<UserListInfoViewModel>();
                for (int i = 0; i < users.Count; i++)
                {
                    userInfoViews.Add(new UserListInfoViewModel
                    {
                        RowId = i + 1,
                        EnglishName = users[i].EnglishName,
                        RealName = users[i].RealName,
                        RoleName = users[i].RoleName,
                        Sex = users[i].Sex,
                        UserName = users[i].UserName
                    });
                }
                return Json(new { code = 0, msg = "SUCCEED", count = users.Count, data = userInfoViews });
            }
            return Json(new { code = 1, msg = "FALSE", count = 0, data = string.Empty });
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        public async Task<IActionResult> AddUser(string userName)
        {
            var courses = await _courseManager.GetAllEntities().ToListAsync();
            UserInfoViewModel userInfoViewModel;
            if (userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                var teacher = _userManager.Users.Where(x => x.UserName == userName).Select(x => new
                {
                    x.Teacher.Birthday,
                    x.Teacher.TName,
                    x.Teacher.EnglishName,
                    x.Teacher.Sex,
                    x.Teacher.Cno,
                    CourseName = (x.Teacher.Course == null) ? null : x.Teacher.Course.Cname,
                }).FirstOrDefault();

                if (user != null && teacher != null)
                {
                    userInfoViewModel = new UserInfoViewModel
                    {
                        //NickName = user.NickName,
                        //UserDesc = user.UserDescription,
                        //UserEmail = user.Email,
                        //UserStatus = user.IsInUsing
                        BirthDate = (teacher.Birthday == null) ? null : teacher.Birthday.ToString(),
                        RealName = teacher.TName,
                        EnglishName = teacher.EnglishName,
                        UserSex = teacher.Sex,
                        UserGrade = user.RoleName,
                        UserName = user.UserName,
                        CourseId = teacher.Cno,
                        CourseName = teacher.CourseName,
                        Courses = courses,
                    };
                    return View(userInfoViewModel);
                }
            }
            userInfoViewModel = new UserInfoViewModel();
            userInfoViewModel.Courses = courses;
            return View(userInfoViewModel);
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            int? courseId;
            if (addUserViewModel.CourseId == 0)
            {
                courseId = null;
            }
            else
            {
                courseId = addUserViewModel.CourseId;
            }
            addUserViewModel.CreateTime = DateTime.Now.ToLocalTime();
            var user = await _userManager.FindByNameAsync(addUserViewModel.UserName);
            if (user == null)
            {

                var result = await _userManager.CreateAsync(new ApplicationIdentityUser
                {
                    UserName = addUserViewModel.UserName,
                    //CreateTime = addUserViewModel.CreateTime,
                    //Sex = addUserViewModel.Sex,
                    //Email = addUserViewModel.Email,
                    //NickName = addUserViewModel.NickName,
                    //IsInUsing = addUserViewModel.IsInUsing,
                    RoleName = addUserViewModel.RoleName,
                    //UserDescription = addUserViewModel.UserDescription，

                    Teacher = new Teacher
                    {
                        Sex = addUserViewModel.Sex,
                        Cno = courseId,
                    },
                }, addUserViewModel.Password);
                if (result.Succeeded)
                {
                    user = await _userManager.FindByNameAsync(addUserViewModel.UserName);
                    if (user == null)
                    {
                        return Json("FALSE");
                    }
                    var role = await _roleManager.FindByIdAsync(addUserViewModel.RoleId);
                    if (role == null)
                    {
                        role = new ApplicationIdentityRole
                        {
                            Id = addUserViewModel.RoleId,
                            Name = addUserViewModel.RoleName
                        };
                        var roleresult = await _roleManager.CreateAsync(role);
                        if (roleresult.Succeeded)
                        {
                            role = await _roleManager.FindByIdAsync(addUserViewModel.RoleId);
                            if (role != null)
                            {
                                var addToRoleResult = await _userManager.AddToRoleAsync(user, role.Name);
                                if (addToRoleResult.Succeeded)
                                {
                                    return Json("SUCCEED");
                                }
                            }
                        }
                        return Json("FALSE");
                    }
                    var addToRoleResult1 = await _userManager.AddToRoleAsync(user, role.Name);
                    if (addToRoleResult1.Succeeded)
                    {
                        return Json("SUCCEED");
                    }
                }
            }
            else
            {
                //user.UserName = addUserViewModel.UserName;
                //user.Email = addUserViewModel.Email;
                //user.NickName = addUserViewModel.NickName;
                //user.IsInUsing = addUserViewModel.IsInUsing;
                var userOldRoles = await _userManager.GetRolesAsync(user);
                if (userOldRoles.Count > 0)
                {
                    var deleteFromRoleResult = await _userManager.RemoveFromRolesAsync(user, userOldRoles);
                    if (!deleteFromRoleResult.Succeeded)
                    {
                        return Json("FALSE");
                    }
                }
                user.RoleName = addUserViewModel.RoleName;
                user.Teacher = new Teacher
                {
                    Sex = addUserViewModel.Sex,
                    Cno = courseId,
                };
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByIdAsync(addUserViewModel.RoleId);
                    if (role == null)
                    {
                        role = new ApplicationIdentityRole
                        {
                            Id = addUserViewModel.RoleId,
                            Name = addUserViewModel.RoleName
                        };
                        var roleResult = await _roleManager.CreateAsync(role);
                        if (!roleResult.Succeeded)
                        {
                            return Json("FALSE");
                        }
                        var addToRoleResult = await _userManager.AddToRoleAsync(user, role.Name);
                        if (addToRoleResult.Succeeded)
                        {
                            return Json("SUCCEED");
                        }
                    }
                    else
                    {
                        var addToRoleResult = await _userManager.AddToRoleAsync(user, role.Name);
                        if (addToRoleResult.Succeeded)
                        {
                            return Json("SUCCEED");
                        }
                    }
                }
            }
            return Json("FALSE");
        }
        [Authorize(Roles = "系统管理员")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userName)
        {
            if (userName == null||userName=="2439739932"||_userManager.Users.Count()==1)
            {
                return Json("FALSE");
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return Json("SUCCEED");
                }
            }
            return Json("FALSE");
        }
        [HttpGet]
        public async Task<IActionResult> UserInfo(string userName)
        {
            UserInfoViewModel userInfoViewModel = new UserInfoViewModel();
            if (userName == null)
            {
                return View(userInfoViewModel);
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "用户查询出错");
                return View(userInfoViewModel);
            }
            var userInfo = _userManager.Users.Where(x => x.UserName == userName).Select(x => new
            {
                NickName = x.Teacher.NickName,
                UserName = x.UserName,
                EnglishName = x.Teacher.EnglishName,
                UserEmail = x.Email,
                UserSex = x.Teacher.Sex,
                UserGrade = x.RoleName,
                Province = x.Teacher.Province,
                City = x.Teacher.City,
                Area = x.Teacher.Area,
                BirthDate = x.Teacher.Birthday,
                RealName = x.Teacher.TName,
                PhoneNumber = x.PhoneNumber,
                UserDesc = x.UserDescription,
                UserFaceImgUrl = x.UserFaceImgUrl,
                CourseName = (x.Teacher.Course == null) ? "无授课信息" : x.Teacher.Course.Cname,
            }).FirstOrDefault();
            userInfoViewModel = new UserInfoViewModel
            {
                NickName = userInfo.NickName,
                EnglishName = userInfo.EnglishName,
                CourseName = userInfo.CourseName,
                UserName = userInfo.UserName,
                UserEmail = userInfo.UserEmail,
                UserSex = userInfo.UserSex,
                UserGrade = userInfo.UserGrade,
                Province = userInfo.Province,
                City = userInfo.City,
                Area = userInfo.Area,
                BirthDate = userInfo.BirthDate,
                RealName = userInfo.RealName,
                PhoneNumber = userInfo.PhoneNumber,
                UserDesc = userInfo.UserDesc,
                UserFaceImgUrl = userInfo.UserFaceImgUrl
            };
            return View(userInfoViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserInfoViewModel userInfoViewModel)
        {
            if (userInfoViewModel == null)
            {
                return Json("FALSE");
            }
            var user = await _userManager.FindByNameAsync(userInfoViewModel.UserName);
            if (user == null)
            {
                return Json("FALSE");
            }
            var userEntity = _userManager.Users.Where(x => x.UserName == user.UserName).Include(x => x.Teacher).FirstOrDefault();

            userEntity.UserDescription = userInfoViewModel.UserDesc;
            userEntity.Teacher.TName = userInfoViewModel.RealName;
            userEntity.Teacher.EnglishName = userInfoViewModel.EnglishName;
            userEntity.Teacher.Province = userInfoViewModel.Province;
            userEntity.Teacher.City = userInfoViewModel.City;
            userEntity.Teacher.Area = userInfoViewModel.Area;
            userEntity.Teacher.Birthday = userInfoViewModel.BirthDate;
            userEntity.Email = userInfoViewModel.UserEmail;
            userEntity.Teacher.NickName = userInfoViewModel.NickName;
            userEntity.PhoneNumber = userInfoViewModel.PhoneNumber;
            userEntity.Teacher.Sex = userInfoViewModel.UserSex;
            userEntity.UserFaceImgUrl = userInfoViewModel.UserFaceImgUrl;
            var result = await _userManager.UpdateAsync(userEntity);
            if (result.Succeeded)
            {
                return Json("SUCCEED");
            }
            return Json("FALSE");
        }
        [Authorize]
        public IActionResult ChangePwd(string userName)
        {
            return View("ChangePwd", userName);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePwd(string userName, string oldPassword, string newPassword)
        {
            if (userName == null || oldPassword == null || newPassword == null)
            {
                return Json("FALSE");
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return Json("未查到用户");
            }
            var result = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
            if (result.Succeeded)
            {
                return Json("SUCCEED");
            }
            return Json("失败");
        }
        public async Task<IActionResult> UserFaceImage(string userName)
        {
            if (userName == null)
            {
                return Content("失败");
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                return Content(user.UserFaceImgUrl);
            }
            return Content("失败");
        }
        [HttpPost]
        public async Task<IActionResult> LoginApi(string userName, string password)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return Json("用户不存在");
            }
            var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
            if (result.Succeeded)
            {
                return Json("SUCCEED");
            }
            return Json("失败");
        }
    }
}
