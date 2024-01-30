$(document).ready(function () {
    let titleInput = $("#Title");
    let titleError = $("#titleError");

    titleInput.on("input", function () {
        let title = titleInput.val();
        let isExceedingLimit = title.length > 50;

        titleError.toggle(isExceedingLimit);
    });
});