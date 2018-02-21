function timer() {
    let seconds = $('#seconds');
    let minutes = $('#minutes');
    let hours = $('#hours');

    let interval = null;
   let startTimer = $('#start-timer').on('click',start);
   let stopTimer = $('#stop-timer').on('click',stop);


    function start() {
        if(interval === null){
            interval = setInterval(updateTime,1000);
        }
    }

    function stop() {
        if(interval !== null){
            clearInterval(interval);
            interval = null;
        }
    }

    function updateTime() {
        let currentSecond = Number(seconds.text()) + 1;
        if (currentSecond === 60) {
            currentSecond = 0;

            let currentMinute = Number(minutes.text()) + 1;
            if (currentMinute === 60) {
                currentMinute = 0;
                hours.text(('0' + Number(hours.text()) + 1).slice(-2));
            }

            minutes.text(('0' + currentMinute).slice(-2));
        }

        seconds.text(('0' + currentSecond).slice(-2));
    }
}
