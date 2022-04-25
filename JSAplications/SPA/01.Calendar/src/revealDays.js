export function revealDays(id, oldId) {

    let obj = {
        'Jan': 1,
        'Feb': 2,
        'Mar': 3,
        'Apr': 4,
        'May': 5,
        'Jun': 6,
        'Jul': 7,
        'Aug': 8,
        'Sept': 9,
        'Oct': 10,
        'Nov': 11,
        'Dec': 12
    };

    let text = `month-${oldId}-${obj[id]}`;

    let days = document.getElementById(text);

    days.style.display = 'block';

    return days;
};