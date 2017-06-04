$(document).ready(function () {

    TryStartClock();
});

function getClock() {
    console.log('Getting clock')
    var c = $('#mon_clock');
    console.log(c);
    return c;
}


function TryStartClock() {
    try {
        SetClock(600);
        console.log("clock started");
    }
    catch (err) {
        console.log('no clock found!')
    }

}

function SetClock(seconds) {

    var ClockSpan = getClock();
    ClockSpan.html('--:--');
    var count = seconds;
    var counter = setInterval(timer, 1000);
    var i = 0;
    function timer() {
        count = count - 1;
        i = i + 1;
        //Elapsed(i);
        if (count <= 0) {
            clearInterval(counter);
            window.location.replace("finished");
            return;
        }
        //Do code for showing the number of seconds here
        var textcero = "";
        if ((count % 60) < 10)
            textcero = "0";
        ClockSpan.html(Math.floor(count / 60).toString() + ":" + textcero + (count % 60).toString());
    }
}