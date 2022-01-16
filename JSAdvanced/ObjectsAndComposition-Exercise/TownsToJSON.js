function convertToJSON(arr) {

    arr.splice(0, 1);
    const towns = [];
    for (const item of arr) {
        const [t, lat, long] = item.split(" | ");

        let tempTown = t.split("| ")[1];
        let tempLat = Number(lat).toFixed(2);
        let tempLong = Number(long.split(" |")[0]).toFixed(2);

        towns.push({ Town: tempTown, Latitude: Number(tempLat), Longitude: Number(tempLong) });
    }

    console.log(JSON.stringify(towns));
}

convertToJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);
convertToJSON(['| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']
)