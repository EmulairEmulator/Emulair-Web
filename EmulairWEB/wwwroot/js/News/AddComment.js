$(document).ready(function () {
    $('.btn-primary').click(function () {
        let commentContainer = document.getElementById("comment");
        let errorMessage = document.getElementById("errorMessage");
        let comment = commentContainer.value;
        let id = commentContainer.dataset.id;
        errorMessage.innerText = "";
        $.ajax({
            url: `/News/AddComment`,
            type: 'POST',
            data: {
                id: id,
                comment: comment
            },
            success: function (response) {
                if (response === true) {
                    toastr.success('Comment was posted!', 'Success');
                    setTimeout(() => { window.location.href = `/News/Details/${id}`; }, "2000");
                }
                else {
                    toastr.error('Failed posting comment.', 'Error');
                }
            },
            error: function (error) {
                errorMessage.innerText = error.responseJSON[0].errorMessage;
            }
        });
    });
});
