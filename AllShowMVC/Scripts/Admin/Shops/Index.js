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
            if (confirm(ResDeleteConfirmMsg)) {
                $.ajax({
                    url: apiUrl + id,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert(ResDeleteSuccessMsg);
                        that.ShopList.splice(index, 1);
                    }
                });
            }
        }
    }
})