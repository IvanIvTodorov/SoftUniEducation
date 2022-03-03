function solve() {
    let departBtn = document.getElementById('depart');
    let arriveBtn = document.getElementById('arrive');

    let text = document.getElementById('info');
    let current = 'depot';
    let currentName = '';
    let res;
    let info;

    async function myFunc(){
        res = await fetch(`http://localhost:3030/jsonstore/bus/schedule`)
        info = await res.json();
    }

    myFunc();

    async function depart() {
        let response = await fetch(`http://localhost:3030/jsonstore/bus/schedule/${current}`)
        let data = await response.json();
        departBtn.disabled = true;
        arriveBtn.disabled = false;

        text.textContent = `Next stop is ${info[data.next].name}`;
        current = info[data.next].next;
        currentName = data.name;
    }

    function arrive() {
        departBtn.disabled = false;
        arriveBtn.disabled = true;

        text.textContent = `Arrived in ${currentName}`;
    }

    return {
        depart,
        arrive
    };
};

let result = solve();