$(function () {
    var arr = [{
        text: '请选择需要的主题',
        iconCls: 'icon-tmenu',
        children: [{
            text: '默认主题',
            value: 'default'
        }, {
            text: 'bootstrap风格',
            value: 'bootstrap'
        }, {
            text: 'gray风格',
            value: 'gray'
        }, {
            text: 'black风格',
            value: 'black'
        }, {
            text: 'material系列',
            children: [{
                text: 'material风格',
                value: 'material'
            }, {
                text: 'material-teal风格',
                value: 'material-teal'
            }, {
                text: 'material-blue风格',
                value: 'material-blue'
            }]
        }, {
            text: 'metro系列',
            children: [{
                text: 'metro风格',
                value: 'metro'
            }, {
                text: 'metro-blue风格',
                value: 'ext-metro/metro-blue'
            }, {
                text: 'metro-gray风格',
                value: 'ext-metro/metro-gray'
            }, {
                text: 'metro-green风格',
                value: 'ext-metro/metro-green'
            }, {
                text: 'metro-orange风格',
                value: 'ext-metro/metro-orange'
            }, {
                text: 'metro-red风格',
                value: 'ext-metro/metro-red'
            }]
        }, {
            text: 'jQueryUI系列',
            children: [{
                text: 'cupertino风格',
                value: 'ext-jqui/ui-cupertino'
            }, {
                text: 'dark-hive风格',
                value: 'ext-jqui/ui-dark-hive'
            }, {
                text: 'pepper-grinder风格',
                value: 'ext-jqui/ui-pepper-grinder'
            }, {
                text: 'sunny风格',
                value: 'ext-jqui/ui-sunny'
            }]
        }]
    }];
    $('#themes').sidemenu({
        width: 20,
        height: 40,
        border: false,
        data: arr,
        collapsed: true,
        onSelect: function (item) {
            var theme = './Content/easyui/themes/' + item.value + '/easyui.css';
            $('#lk').attr('href', theme);
        }
    });
    $('#ts').datagrid({
        rownumbers: true,
        striped: true,
        loadMsg:'数据加载中...',
        height:500,
        url: '/Student/List',
        columns: [[
            {field:'ck',checkbox:true},
            {field:'StudentId',title:'学生编号',halign:'center',width:'10%'},
            {field:'StudentName',title:'学生姓名',halign:'center',width:'10%'},
            {field:'StudentAddress',title:'地址',halign:'center',width:'20%'},
            {field:'PhoneNumber',title:'联系电话',halign:'center',width:'10%'},
            {field:'Gender',title:'性别',halign:'center',width:'10%'}
        ]],
        pagination:true
    })
})