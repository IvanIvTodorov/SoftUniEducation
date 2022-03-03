function attachEvents() {
    let btn = document.getElementById('submit');
    let input = document.getElementById('location');
    let curNames = {};
    let current = document.getElementById('current');
    let next = document.getElementById('upcoming');

    btn.addEventListener('click', click);
    function click() {
        try {
            onClick();
            current.children[1].remove();
            current.children[1].remove();
            async function onClick() {
                const response = await fetch(`http://localhost:3030/jsonstore/forecaster/locations`);
                const data = await response.json();

                for (const item of data) {
                    curNames[item.name] = item.code;
                };

                async function getLocations() {

                    let code = '';
                    if (Object.keys(curNames).includes(input.value)) {
                        code = curNames[input.value];
                    }
                    const today = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`);
                    const todayData = await today.json();

                    const upcoming = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`);
                    const upData = await upcoming.json();

                    console.log(todayData, upData);

                    forecast.style.display = 'block';

                    let div = document.createElement('div');
                    div.classList.add('forecasts');

                    let span = document.createElement('span');
                    span.classList.add('condition', 'symbol');

                    if (todayData.forecast.condition == 'Sunny') {
                        span.innerHTML = `&#x2600`;
                    } else if (todayData.forecast.condition == 'Overcast') {
                        span.innerHTML = `&#x2601`;
                    } else if (todayData.forecast.condition == 'Rain') {
                        span.innerHTML = `&#x2614`;
                    } else if (todayData.forecast.condition == 'Partly sunny') {
                        span.innerHTML = '&#x26C5'
                    }

                    let secSpan = document.createElement('span');
                    secSpan.classList.add('condition');

                    let spanName = document.createElement('span');
                    spanName.textContent = todayData.name;

                    let spanTemp = document.createElement('span');
                    spanTemp.textContent = `${todayData.forecast.low}/\u00B0${todayData.forecast.high}\u00B0`
                    let spanData = document.createElement('span');
                    spanData.textContent = todayData.forecast.condition;

                    let arr = [spanName, spanTemp, spanData];

                    for (const span of arr) {
                        span.classList.add('forecast-data');
                    };

                    current.appendChild(span);
                    secSpan.appendChild(spanName);
                    secSpan.appendChild(spanTemp);
                    secSpan.appendChild(spanData);
                    current.appendChild(secSpan);

                    let divSecond = document.createElement('div');
                    divSecond.classList.add(`forecast-info`);

                    let spanSec = document.createElement('span');
                    spanSec.classList.add('upcoming');

                    let spanIcon = document.createElement('span');
                    spanIcon.classList.add('symbol');
                    
                    if (upData.forecast[0].condition == 'Sunny') {
                        spanIcon.innerHTML = `&#x2600`;
                    } else if (upData.forecast[0].condition == 'Overcast') {
                        spanIcon.innerHTML = `&#x2601`;
                    } else if (upData.forecast[0].condition == 'Rain') {
                        spanIcon.innerHTML = `&#x2614`;
                    } else if (upData.forecast[0].condition == 'Partly sunny') {
                        spanIcon.innerHTML = '&#x26C5'
                    };


                    let spanDegree = document.createElement('span');
                    spanDegree.classList.add('forecast-data');
                    spanDegree.textContent = `${upData.forecast[0].low}/\u00B0${upData.forecast[0].high}\u00B0`
                   
                    let spanCondition = document.createElement('span'); 
                    spanCondition.classList.add('forecast-data');
                    spanCondition.textContent = upData.forecast[0].condition;

                    next.appendChild(divSecond);
                    spanSec.appendChild(spanIcon);
                    spanSec.appendChild(spanDegree);
                    spanSec.appendChild(spanCondition);

                    next.appendChild(spanSec);
                };

                getLocations();
            };

        } catch (error) {

        }

    }

};

attachEvents();