new Vue({
    el: '#app',
    data: {
        AuthorityList: null
    },
    mounted() {
        baseInstance.get('/api/Authority')
            .then(response => {
                this.AuthorityList = response.data.Data;
            });
    },
    methods: {
        EditAuth(id1, id2) {
            location.href = url + '/Edit?EmpNo=' + id1 + "&AuthorityNo=" + id2;
        },
        AuthDetail(id1, id2) {
            location.href = url + '/Details?EmpNo=' + id1 + "&AuthorityNo=" + id2;
        },
        DeleteAuth(index, id1, id2) {
            var that = this;
            if (confirm(ResDeleteConfirmMsg)) {
                $.ajax({
                    url: apiUrl + '?EmpNo=' + id1 + "&AuthorityNo=" + id2,
                    type: 'DELETE',
                    success: function (data, textStatus, xhr) {
                        alert(ResDeleteSuccessMsg);
                        that.AuthorityList.splice(index, 1);
                    }
                });
            }
        }
    }
})