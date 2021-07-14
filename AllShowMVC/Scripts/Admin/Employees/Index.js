// 定義過濾器
// https://ithelp.ithome.com.tw/articles/10248137
//Vue.filter('timeString', function (value, myFormat) {
//    return moment(value).format(myFormat || 'YYYY-MM-DD, HH:mm:ss');
//});

new Vue({
    el: '#app',
    data: {
        EmployeeList: null
    },
    mounted() {
        baseInstance.get('/api/Employees')
            .then(response => {
                this.EmployeeList = response.data.Data;
            });
    },
    filters: {
        dateFormat: function (value, myFormat) {
            return moment(value).format(myFormat || 'YYYY-MM-DD, HH:mm:ss');
        }
    },
    methods: {
        EditEmp(id) {
            location.href = url + '/Edit/' + id;
        },
        EmpDetail(id) {
            location.href = url + '/Details/' + id;
        },
        DeleteEmp(index, id) {
            var that = this;
            if (confirm(ResDeleteConfirmMsg)) {
                $.ajax({
                    url: apiUrl + id,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert(ResDeleteSuccessMsg);
                        that.EmployeeList.splice(index, 1);
                    },
                    error: function (xhr, textStatus, errorThrown) {
                        alert(ResErrorMsg);
                    }
                });
            }
        }
    }
})