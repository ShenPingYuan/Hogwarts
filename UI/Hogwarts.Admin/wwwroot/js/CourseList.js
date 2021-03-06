﻿layui.use(['form', 'layer', 'table', 'laytpl'], function () {
    var form = layui.form,
        layer = parent.layer === undefined ? layui.layer : top.layer,
        $ = layui.jquery,
        laytpl = layui.laytpl,
        table = layui.table;

    //用户列表
    var tableIns = table.render({
        elem: '#courseList',
        url: '/Course/Courses',
        cellMinWidth: 95,
        page: true,
        height: "full-125",
        limits: [10, 15, 20, 25, 50],
        limit: 20,
        id: "courseListTable",
        cols: [[
            { type: "checkbox", fixed: "left", width: 50 },
            { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
            //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
            { field: 'courseId', title: '课程编号', minWidth: 100, align: "center" },
            //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
            //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
            { field: 'courseName', title: '课程名', minWidth: 100, align: "center" },
            { field: 'englishName', title: 'Course English Name', minWidth: 100, align: "center" },
            { field: 'courseScore', title: '课程学分', minWidth: 100, align: "center" },

            { title: '操作', minWidth: 175, templet: '#courseListBar', fixed: "right", align: "center" }
        ]]
    });

    table.on('tool(courseList)', function (obj) {
        var layEvent = obj.event,
            data = obj.data;

        if (layEvent === 'edit') { //编辑
            addUser(data);
        } else if (layEvent === 'usable') { //启用禁用
            var _this = $(this),
                usableText = "是否确定禁用此用户？",
                btnText = "已禁用";
            if (_this.text() == "已禁用") {
                usableText = "是否确定启用此用户？",
                    btnText = "已启用";
            }
            layer.confirm(usableText, {
                icon: 3,
                title: '系统提示',
                cancel: function (index) {
                    layer.close(index);
                }
            }, function (index) {
                _this.text(btnText);
                layer.close(index);
            }, function (index) {
                layer.close(index);
            });
        } else if (layEvent === 'del') { //删除
            layer.confirm('确定删除此课程？', { icon: 3, title: '提示信息' }, function (index) {
                //$.get("/Account/DeleteUser",{
                //    newsId : data.newsId  //将需要删除的newsId作为参数传入
                //},function(data){
                //   tableIns.reload();
                //   layer.close(index);
                // })
                var index = top.layer.msg('数据提交中，请稍候', { icon: 16, time: false, shade: 0.8 });
                $.ajax({
                    url: "/Course/DeleteCourse",
                    type: "POST",
                    data: {
                        CourseId: data.courseId
                    },
                    dataType: "json",
                    success: function (res) {
                        tableIns.reload();
                        layer.close(index);
                    }
                })
            });
        }
    });

    $(".searchVal").keyup(function () {
        var keywords = "";
        if ($(".searchVal").val() != "") {
            keywords = '?keyWords=' + $(".searchVal").val();
        } else {
            table.render({
                elem: '#courseList',
                url: '/Course/SearchCourseFuzzy',
                cellMinWidth: 95,
                page: true,
                height: "full-125",
                limits: [10, 15, 20, 25],
                limit: 10,
                id: "courseListTable",
                cols: [[
                    { type: "checkbox", fixed: "left", width: 50 },
                    { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
                    //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
                    { field: 'courseId', title: '课程编号', minWidth: 100, align: "center" },
                    //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
                    //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
                    { field: 'courseName', title: '课程名', minWidth: 100, align: "center" },
                    { field: 'englishName', title: 'Course English Name', minWidth: 100, align: "center" },
                    { field: 'courseScore', title: '课程学分', minWidth: 100, align: "center" },

                    { title: '操作', minWidth: 175, templet: '#courseListBar', fixed: "right", align: "center" }
                ]]
            });
            return false;
        }
        table.render({
            elem: '#courseList',
            url: '/Course/SearchCourseFuzzy' + keywords,
            cellMinWidth: 95,
            page: true,
            height: "full-125",
            limits: [10, 15, 20, 25],
            limit: 10,
            id: "courseListTable",
            cols: [[
                { type: "checkbox", fixed: "left", width: 50 },
                { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
                //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
                { field: 'courseId', title: '课程编号', minWidth: 100, align: "center" },
                //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
                //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
                { field: 'courseName', title: '课程名', minWidth: 100, align: "center" },
                { field: 'englishName', title: 'Course English Name', minWidth: 100, align: "center" },
                { field: 'courseScore', title: '课程学分', minWidth: 100, align: "center" },

                { title: '操作', minWidth: 175, templet: '#courseListBar', fixed: "right", align: "center" }
            ]]
        });
    });
    //搜索【此功能需要后台配合，所以暂时没有动态效果演示】
    $(".search_btn").on("click", function () {
        if ($(".searchVal").val() != '') {
            table.render({
                elem: '#courseList',
                url: '/Course/SearchCourseFuzzy?keyWords=' + $(".searchVal").val(),
                cellMinWidth: 95,
                page: true,
                height: "full-125",
                limits: [10, 15, 20, 25],
                limit: 10,
                id: "courseListTable",
                cols: [[
                    { type: "checkbox", fixed: "left", width: 50 },
                    { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
                    //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
                    { field: 'courseId', title: '课程编号', minWidth: 100, align: "center" },
                    //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
                    //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
                    { field: 'courseName', title: '课程名', minWidth: 100, align: "center" },
                    { field: 'englishName', title: 'Course English Name', minWidth: 100, align: "center" },
                    { field: 'courseScore', title: '课程学分', minWidth: 100, align: "center" },

                    { title: '操作', minWidth: 175, templet: '#courseListBar', fixed: "right", align: "center" }
                ]]
            });
        } else {
            layer.msg("请输入搜索的内容");
        }
    });

    //添加用户
    function addUser(edit) {
        var para = "";
        if (typeof (edit) != "undefined") {
            para = "?CourseId=" + edit.courseId;
        }
        var index = layui.layer.open({
            title: "添加用户",
            type: 2,
            content: "/Course/AddCourse" + para,
            success: function (layero, index) {
                var body = layui.layer.getChildFrame('body', index);
                //if (edit) {
                //    body.find(".nickName").val(edit.nickName);
                //    body.find(".userName").val(edit.userName);  //登录名
                //    body.find(".userEmail").val(edit.userEmail);  //邮箱
                //    body.find(".userSex input[value=" + edit.userSex + "]").attr("checked", "checked");  //性别
                //    body.find(".userGrade").val(edit.userGrade);  //会员等级
                //    body.find(".userStatus").val(edit.userStatus);    //用户状态
                //    body.find(".userDesc").text(edit.userDesc);    //用户简介
                //    form.render();
                //}
                setTimeout(function () {
                    layui.layer.tips('点击此处返回用户列表', '.layui-layer-setwin .layui-layer-close', {
                        tips: 3
                    });
                }, 500)
            }
        })
        layui.layer.full(index);
        window.sessionStorage.setItem("index", index);
        //改变窗口大小时，重置弹窗的宽高，防止超出可视区域（如F12调出debug的操作）
        $(window).on("resize", function () {
            layui.layer.full(window.sessionStorage.getItem("index"));
        })
    }
    $(".addNews_btn").click(function () {
        addUser();
    })

    //批量删除
    $(".delAll_btn").click(function () {
        var checkStatus = table.checkStatus('courseListTable'),
            data = checkStatus.data,
            CourseId = [];
        if (data.length > 0) {
            for (var i in data) {
                CourseId.push(data[i].courseId);
            }
            layer.confirm('确定删除选中的课程？', { icon: 3, title: '提示信息' }, function (index) {
                $.ajax({
                    url: "/Course/DeleteCourses",
                    type: "POST",
                    data: {
                        CourseIds: CourseId,
                    },
                    success: function (res) {
                        if (res.count == CourseId.length) {
                            layer.msg("已成功删除" + res.count + "条数据");
                            tableIns.reload();
                            layer.close(index);
                        } else if (0 < res.count < CourseId.length) {
                            layer.msg("只删除部分数据，删除了" + res.count + "条数据");
                            tableIns.reload();
                            layer.close(index);
                        } else {
                            layer.msg("删除失败");
                            tableIns.reload();
                            layer.close(index);
                        }
                    }
                })

                // })
            })
        } else {
            layer.msg("请选择需要删除的数据");
        }
    })

})
