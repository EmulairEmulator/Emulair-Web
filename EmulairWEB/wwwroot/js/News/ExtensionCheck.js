$(document).ready(function () {
    let imagesInput = $("#images");
    let imagesExtensionError = $("#imagesExtensionError");
    let imagesError = $("#imagesError");
    let submitButton = $("#submit-button-images");
    let errorMessageTitle = document.getElementById("errorMessageTitle");
    let errorMessageDescription = document.getElementById("errorMessageDescription");

    imagesInput.on("change", function () {
        let selectedFiles = imagesInput[0].files;
        let isExtensionValid = true;
        let isValid = true;

        for (let i = 0; i < selectedFiles.length; i++) {
            let file = selectedFiles[i];
            let allowedExtensions = ["jpg", "jpeg", "png"];
            let fileExtension = file.name.split(".").pop().toLowerCase();

            if (!allowedExtensions.includes(fileExtension)) {
                isExtensionValid = false;
                break;
            }
        }
        if (selectedFiles.length == 0)
            isValid = false;

        imagesExtensionError.toggle(!isExtensionValid); 
        imagesError.toggle(!isValid);
        submitButton.prop("disabled", !isValid || !isExtensionValid); 
    });

    $(".btn-primary").click(function () {
        if (!imagesInput.prop("disabled") && imagesInput[0].files.length === 0) {
            alert("Please select at least one valid image file (jpg or png).");
            imagesError.toggle(true);
            submitButton.prop("disabled", true);
        }
        else {
            let title = $("#title").val();
            let description = $("#description").val();
            let formData = new FormData();
            for (let i = 0; i < imagesInput[0].files.length; i++) {
                formData.append("formFiles", imagesInput[0].files[i]);
            }
            formData.append("Title", title);
            formData.append("Description", description);
            errorMessageDescription.innerText = "";
            errorMessageTitle.innerText = "";
            imagesError.innerText = "";
            $.ajax({
                url: `/News/Create`,
                type: 'POST',
                data: formData,
                processData: false, 
                contentType: false,
                success: function (response) {
                    if (response) {
                        toastr.success('News created successfully!', 'Success');

                        setTimeout(() => { window.location.href = "/News/Index"; }, "2000");
                    }
                    else {
                        toastr.error('Failed to create news.', 'Error');
                    }
                },
                error: function (error) {
                    for (let i = 0; i < error.responseJSON.length; i++) {
                        let element = document.getElementById(`errorMessage${error.responseJSON[i].propertyName}`);
                        element.innerText = error.responseJSON[i].errorMessage;
                    }
                    
                }
            });
        }
    });
});
