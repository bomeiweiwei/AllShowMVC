new Vue({
    el: '#app',
    data: {
        ShopList: null
    },
    mounted() {
        baseInstance.get('/api/Shops')
            .then(response => {
                this.ShopList = response.data.Data;
            });
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
            if (confirm("確定刪除該筆資料?")) {
                $.ajax({
                    url: apiUrl + id,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert("刪除成功");
                        that.ShopList.splice(index, 1);
                    }
                });
            }
        }
    }
})