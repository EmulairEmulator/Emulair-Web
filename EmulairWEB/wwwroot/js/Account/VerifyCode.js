$(document).ready(function () {
    $('.entry-data').click(function () {
        let emailInput = document.getElementById("email");
        let emailValue = emailInput.value;
        let codeInput = document.getElementById("code");
        let codeValue = codeInput.value;
        let button = document.getElementById("verify-code");
        let buttonPass = document.getElementById("reset-password");
        $.ajax({
            url: `/Account/CreateNewPassword?email=${emailValue}&code=${codeValue}`,
            type: 'POST',
            success: function (response) {
                if (response === true) {
                    emailInput.style.display = "none";
                    codeInput.style.display = "none";
                    let codeLabelInput = document.getElementById("codeLabel");
                    let emailLabelInput = document.getElementById("emailLabel");
                    codeLabelInput.style.display = "none";
                    emailLabelInput.style.display = "none";
                    button.style.display = "none";
                    let newPasswordInput = document.getElementById("newPassword");
                    newPasswordInput.style.display = "block";
                    let newPasswordLabelInput = document.getElementById("newPasswordLabel");
                    newPasswordLabelInput.style.display = "block";
                    let confirmPasswordInput = document.getElementById("confirmPassword");
                    confirmPasswordInput.style.display = "block";
                    let confirmPasswordLabelInput = document.getElementById("confirmPasswordLabel");
                    confirmPasswordLabelInput.style.display = "block";
                    buttonPass.style.display = "block";
                }
                else {
                    toastr.error('Wrong email or code is not valid!', 'Error');
                }
            }
        });
    });

    $('.Reset-Password').click(function () {
        let newPasswordInput = document.getElementById("newPassword");
        let newPasswordValue = newPasswordInput.value;
        let confirmPasswordInput = document.getElementById("confirmPassword");
        let confirmPasswordValue = confirmPasswordInput.value;
        let emailInput = document.getElementById("email");
        let emailValue = emailInput.value;
        $.ajax({
            url: `/Account/ValidatePassword?newPassword=${newPasswordValue}&confirmPassword=${confirmPasswordValue}&email=${emailValue}`,
            type: 'POST',
            success: function (response) {
                if (response === true) {
                    toastr.success('Password was changed!', 'Success');
                    setTimeout(() => { window.location.href = "/Account/Login"; }, "1000");
                }
                else {
                    toastr.error('Error creating new password!', 'Error');
                }
            }
        });
    });

});
