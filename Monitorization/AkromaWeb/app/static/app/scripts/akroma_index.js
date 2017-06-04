$(document).ready(function () {
    $('.LargeMonitorizationBtn').on('click', function (event) {
        StartMonitorization();
    })

});

function StartMonitorization() {
    console.log("Monitorization started")
    window.location.replace("mon");
}