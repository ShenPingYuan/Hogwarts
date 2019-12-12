﻿layui.use(['form', 'layer', 'table', 'laytpl'], function () {
    var form = layui.form,
        layer = parent.layer === undefined ? layui.layer : top.layer,
        $ = layui.jquery,
        laytpl = layui.laytpl,
        table = layui.table;

    //用户列表
    var tableIns = table.render({
        elem: '#searchStudentList',
        url: '/Student/SearchStudents',
        cellMinWidth: 95,
        page: true,
        height: "full-125",
        limits: [10, 15, 20, 25],
        limit: 10,
        id: "searchStudentListTable",
        cols: [[
            { type: "checkbox", fixed: "left", width: 50 },
            { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
            //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
            { field: 'studentId', title: '学号', minWidth: 100, align: "center" },
            //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
            //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
            { field: 'studentName', title: '学生名', minWidth: 100, align: "center" },
            { field: 'englishName', title: '英文名', minWidth: 100, align: "center" },
            { field: 'sex', title: '性别', minWidth: 100, align: "center" },
            //{ field: 'birthday', title: '生日', minWidth: 100, align: "center" },
            { field: 'year', title: '入学年份', minWidth: 100, align: "center" },
            { field: 'className', title: '学院名', minWidth: 100, align: "center" },
            { field: 'character', title: '特性', minWidth: 100, align: "center" },
            //{ field: 'courseClass', title: '开课院系', minWidth: 100, align: "center" },
            //{ field: 'courseName', title: '课程名', minWidth: 100, align: "center" },
            //}
            //{ field: 'realName', title: '名字', minWidth: 100, align: "center" },
            //{ field: 'englishName', title: '英文名', minWidth: 100, align: "center" },
            //{
            //    field: 'sex', title: '用户性别', width: 120, align: 'center', templet: function (d) {
            //        if (d.sex == null) return "就不告诉你";
            //        return d.sex;
            //    }
            //},
            //{
            //    field: 'userStatus', title: '用户状态', align: 'center', templet: function (d) {
            //        return d.userStatus == true ? "正常使用" : "限制使用";
            //    }
            //},
            //{ field: 'roleName', title: '职位', align: 'center' },
            //{field: 'userEndTime', title: '最后登录时间', align:'center',minWidth:150},
            { title: '操作', minWidth: 175, templet: '#newStudentListBar', fixed: "right", align: "center" }
        ]]
    });
    //搜索【此功能需要后台配合，所以暂时没有动态效果演示】
    $(".search_btn").on("click", function () {
        if ($(".searchVal").val() != '') {
            table.render({
                elem: '#searchStudentList',
                url: '/Student/SearchStudents?keyWords=' + $(".searchVal").val(),
                cellMinWidth: 95,
                page: true,
                height: "full-125",
                limits: [10, 15, 20, 25],
                limit: 10,
                id: "searchStudentListTable",
                cols: [[
                    { type: "checkbox", fixed: "left", width: 50 },
                    { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
                    //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
                    { field: 'studentId', title: '学号', minWidth: 100, align: "center" },
                    //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
                    //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
                    { field: 'studentName', title: '学生名', minWidth: 100, align: "center" },
                    { field: 'englishName', title: '英文名', minWidth: 100, align: "center" },
                    { field: 'sex', title: '性别', minWidth: 100, align: "center" },
                    //{ field: 'birthday', title: '生日', minWidth: 100, align: "center" },
                    { field: 'year', title: '入学年份', minWidth: 100, align: "center" },
                    { field: 'className', title: '学院名', minWidth: 100, align: "center" },
                    { field: 'character', title: '特性', minWidth: 100, align: "center" },
                    { field: 'province', title: '省份', minWidth: 100, align: "center" },
                    { field: 'city', title: '城市', minWidth: 100, align: "center" },
                    { field: 'area', title: '地区', minWidth: 100, align: "center" },
                ]]
            });
        } else {
            layer.msg("请输入搜索的内容");
        }
    });

    $(".search_btn_fuzzy").on("click", function () {
        if ($(".searchVal").val() != '') {
            table.render({
                elem: '#searchStudentList',
                url: '/Student/FuzzySearchStudents?keyWords=' + $(".searchVal").val(),
                cellMinWidth: 95,
                page: true,
                height: "full-125",
                limits: [10, 15, 20, 25],
                limit: 10,
                id: "searchStudentListTable",
                cols: [[
                    { type: "checkbox", fixed: "left", width: 50 },
                    { field: "rowId", title: 'ID', width: 60, fixed: "left", sort: "true", align: 'center', edit: 'text' },
                    //{field: 'nickName', title: '昵称', minWidth:100, align:"center"},
                    { field: 'studentId', title: '学号', minWidth: 100, align: "center" },
                    //{field: 'userEmail', title: '用户邮箱', minWidth:200, align:'center',templet:function(d){
                    //    return '<a class="layui-blue" href="mailto:'+d.userEmail+'">'+d.userEmail+'</a>';
                    { field: 'studentName', title: '学生名', minWidth: 100, align: "center" },
                    { field: 'englishName', title: '英文名', minWidth: 100, align: "center" },
                    { field: 'sex', title: '性别', minWidth: 100, align: "center" },
                    //{ field: 'birthday', title: '生日', minWidth: 100, align: "center" },
                    { field: 'year', title: '入学年份', minWidth: 100, align: "center" },
                    { field: 'className', title: '学院名', minWidth: 100, align: "center" },
                    { field: 'character', title: '特性', minWidth: 100, align: "center" },
                    { field: 'province', title: '省份', minWidth: 100, align: "center" },
                    { field: 'city', title: '城市', minWidth: 100, align: "center" },
                    { field: 'area', title: '地区', minWidth: 100, align: "center" },
                ]]
            });
        } else {
            layer.msg("请输入搜索的内容");
        }
    });
    //批量删除
    $(".delAll_btn").click(function () {
        var checkStatus = table.checkStatus('courseListTable'),
            data = checkStatus.data,
            newsId = [];
        if (data.length > 0) {
            for (var i in data) {
                newsId.push(data[i].newsId);
            }
            layer.confirm('确定删除选中的用户？', { icon: 3, title: '提示信息' }, function (index) {
                // $.get("删除文章接口",{
                //     newsId : newsId  //将需要删除的newsId作为参数传入
                // },function(data){
                tableIns.reload();
                layer.close(index);
                // })
            })
        } else {
            layer.msg("请选择需要删除的用户");
        }
    })

})
