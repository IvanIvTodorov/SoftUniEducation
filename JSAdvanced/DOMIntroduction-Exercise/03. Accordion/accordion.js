function toggle() {

    let buttonText = document.getElementsByClassName('button')[0];

    if (buttonText.textContent == "More") {
        buttonText.textContent = 'Less';
        document.getElementById('extra').style.display = 'block';
    }else{
        buttonText.textContent = 'More';
        document.getElementById('extra').style.display = 'none';
    }
    console.log(buttonText);
}