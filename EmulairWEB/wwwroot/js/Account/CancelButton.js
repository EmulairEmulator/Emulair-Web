let cancelButton = document.getElementById('cancelButton');

cancelButton.onclick = () => {
    console.log("sunt aici");
    var listingId = cancelButton.value;
    $.ajax({
        url: `/Listing/CancelBid`,
        type: 'POST',
        data: {
            Id: listingId
        },
        success: function (response) {
            if (response) {
                toastr.success('Bid successfully cancelled!', 'Success');
            }
            else {
                toastr.error('Failed to cancel bid.', 'Error');
                //setTimeout(() => { window.location.href = "/UserAccount/Login"; }, "2000");
            }
        }
    });
};