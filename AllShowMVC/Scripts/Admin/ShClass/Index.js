new Vue({
    el: '#app',
    data: {
        ShClassList: null
    },
    mounted() {
        baseInstance.get('/api/ShClasses')
            .then(response => {
                this.ShClassList = response.data.Data;
            });
    },
    methods: {
        EditShClass(id) {
            location.href = url + '/Edit/' + id;
        },
        ShClassDetail(id) {
            location.href = url + '/Details/' + id;
        },
        DeleteShClass(index, id) {
            var that = this;
            if (confirm("確定刪除該筆資料?")) {
                $.ajax({
                    url: apiUrl + id,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert("刪除成功");
                        that.ShClassList.splice(index, 1);
                    }
                });
            }
        }
    }
})