function attachGradientEvents() {
    let element = document.getElementById('gradient');
    let result = document.getElementById('result');

    element.addEventListener('mousemove', onMove);

    function onMove(ev){
        
        let calc = Math.floor(ev.offsetX / element.clientWidth * 100);

        result.textContent = `${calc}%`;
    }
}