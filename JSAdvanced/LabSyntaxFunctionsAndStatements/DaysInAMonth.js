function calcDays(month, year) {
    
    let date = new Date(year, month, 0).getDate();

    console.log(date);
}

calcDays(2, 2022);