$(document).ready(function () {
    $("#addCommentButton").click(function () {
        var commentText = $("#comment").val();
        var newsId = $("#comment").data("id");

        toastr.success("Comment added successfully!");

        $("#comment").val("");
    });
});
