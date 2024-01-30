let balance = document.getElementById('balance');
$.ajax({
    url: `/Account/DisplayBalance`,
    type: 'GET',
    success: function (response) {
        if (response) {
            balance.innerText = response;
        }
    }
});