function previousDay(year,month,day) {
    
    let date = new Date(year,month -1,day);
    let yesterday = new Date(date.getTime() - 24*60*60*1000);

    console.log(`${yesterday.getFullYear()}-${yesterday.getMonth() + 1}-${yesterday.getDate()}`)

}

previousDay(2016,10,1)
previousDay(2016,9,30)