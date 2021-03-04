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
    methods: {
        EditEmp(id) {
            location.href = url + '/Edit/' + id;
        },
        DetailEmp(id) {
            location.href = url + '/Details/' + id;
        },
        DeleteEmp(index, id) {
            var that = this;
            if (confirm("確定刪除該筆資料?")) {
                $.ajax({
                    url: apiUrl + id,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert("刪除成功");
                        that.EmployeeList.splice(index, 1);
                    }
                });
            }
        }
    }
})