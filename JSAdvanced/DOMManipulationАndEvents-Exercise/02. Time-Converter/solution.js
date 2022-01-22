function attachEventsListeners() {

    let days = document.getElementById('daysBtn');
    let hours = document.getElementById('hoursBtn');
    let min = document.getElementById('minutesBtn');
    let sec = document.getElementById('secondsBtn');

    let arr = [days, hours, min, sec];

    for (const button of arr) {
        button.addEventListener('click', onClick);
    }

    let dayVal = document.getElementById('days');
    let hourVal = document.getElementById('hours');
    let minVal = document.getElementById('minutes');
    let secVal = document.getElementById('seconds');

    function onClick(ev) {
        if (ev.target === days) {

            hourVal.value = dayVal.value * 24;
            minVal.value = hourVal.value * 60;
            secVal.value = minVal.value * 60;

        } else if (ev.target == hours) {

            dayVal.value = hourVal.value / 24
            minVal.value = hourVal.value * 60;
            secVal.value = minVal.value * 60;

        } else if (ev.target === min) {

            secVal.value = minVal.value * 60;
            hourVal.value = minVal.value / 60;
            dayVal.value = hourVal.value / 24

        } else {

            minVal.value = secVal.value / 60;
            hourVal.value = minVal.value / 60;
            dayVal.value = hourVal.value / 24;
        }
    }
}