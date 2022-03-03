async function getInfo() {

    let inputVal = document.getElementById('stopId');
    let stopName = document.getElementById('stopName');
    let busesInfo = document.getElementById('buses');

    stopName.textContent = '';
    busesInfo.innerHTML = '';
    try {
        const response = await fetch(`http://localhost:3030/jsonstore/bus/businfo/${inputVal.value}`)
        const data = await response.json();

        console.log(data);
        for (const item of Object.values(data)) {         
            for (const bus of Object.keys(item)) {
                let li = document.createElement('li');
                li.textContent = `Bus ${bus} arrives in ${item[bus]} minutes.`;
                busesInfo.appendChild(li);
            };
            break;
        };

        stopName.textContent = data.name;
    } catch (error) {
        stopName.textContent = `Error: ${error.message}`;
    }

    inputVal.value = '';
}