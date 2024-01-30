$(document).ready(function () {
    $('.reset-password').click(function () {
        let emailInput = document.getElementById("Email");
        let emailValue = emailInput.value;
        $.ajax({
            url: `/Account/ResetPassword?email=${emailValue}`,
            type: 'POST',
            success: function (response) {
                if (response === true) {
                    toastr.success('Code to reset password was sent!', 'Success');
                    setTimeout(() => { window.location.href = "/Account/CreateNewPassword"; }, "2000");
                }
                else {
                    toastr.error('Failed to send reset code.', 'Error');
                }
            }
        });
    });
});
