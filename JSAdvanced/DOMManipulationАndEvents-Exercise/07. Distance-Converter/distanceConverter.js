function attachEventsListeners() {
    let button = document.getElementById('convert');

    button.addEventListener('click', onClick);

    function onClick() {
        let from = document.getElementById('inputUnits').value;
        let to = document.getElementById('outputUnits').value;
        let fromValue = document.getElementById('inputDistance').value;
        let toValue = document.getElementById('outputDistance');
        toValue.disabled = false

        switch (from){
            case 'km':
                fromValue = fromValue * 1000;
              break;
            case 'm':
                fromValue = fromValue;
              break;
            case 'cm':
                fromValue = fromValue * 0.01;
              break;
            case 'mm':
                fromValue = fromValue * 0.001;
              break;
            case 'mi':
                fromValue = fromValue * 1609.34;
              break;
            case 'yrd':
                fromValue = fromValue * 0.9144;
              break;
            case 'ft':
                fromValue = fromValue * 0.3048;
              break;
            case 'in':
                fromValue = fromValue * 0.0254;
              break;
          }
      
          switch (to){
            case 'km':
                toValue.value = fromValue / 1000;
              break;
            case 'm':
                toValue.value = fromValue;
              break;
            case 'cm':
                toValue.value = fromValue / 0.01;
              break;
            case 'mm':
                toValue.value = fromValue / 0.001;
              break;
            case 'mi':
                toValue.value = fromValue / 1609.34;
              break;
            case 'yrd':
                toValue.value = fromValue / 0.9144;
              break;
            case 'ft':
                toValue.value = fromValue / 0.3048;
              break;
            case 'in':
                toValue.value = fromValue / 0.0254;
              break;
          }
    }
}