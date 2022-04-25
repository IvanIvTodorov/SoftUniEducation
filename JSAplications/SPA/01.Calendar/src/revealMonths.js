export function revealMonths(id){
    
    let text = `year-` + id;

    let months = document.getElementById(text);
    months.style.display = 'block';
    
    return months;
};

