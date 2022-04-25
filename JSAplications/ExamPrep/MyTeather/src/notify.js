const element = document.querySelector('#errorBox')
const span = element.querySelector('span');

export function notify(msg){
    span.textContent = msg;
    element.style.display = 'block';
    
    setTimeout(() => element.style.display ='none', 3000);
};