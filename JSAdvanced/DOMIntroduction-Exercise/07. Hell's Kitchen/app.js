function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      let input = document.querySelector('textarea').value;
      let splited = input.split(/[\'\[\"\]]+/g).filter(x => x && x != ',');
      let restaurantCol = [];

      for (const restaurant of splited) {
         let workers = restaurant.split(/[\s\-\,]+/);
         let name = workers.shift();
         let workersCol = [];

         if (!restaurantCol.find(x => x.restName === name)) {
            restaurantCol.push({
               restName: name,
               workers: []
            });
         };

         for (let index = 0; index < workers.length; index += 2) {

            let workName = workers[index];
            let workSal = workers[index + 1];

            const currentRest = restaurantCol.find(x => x.restName === name);
            currentRest.workers.push({
               name: workName,
               salary: Number(workSal)
            });
            currentRest.workers.sort((a,b) => b.salary - a.salary);
         }
         
      }

      let compare = 0;
      let bestName = '';
      for (const obj of restaurantCol) {
         let current = 0;
         for (const arr of obj.workers) {

            current += arr.salary;
         }

         current /= obj.workers.length;

         if (current > compare) {
            compare = current;
            bestName = obj.restName;
         }
      }

      let best = restaurantCol.filter(n => n.restName == bestName);

      let arrOfNames = [];
      console.log(arrOfNames);
      let bestSal = 0;
      for (const obj of Object.entries(best)) {
         bestSal = obj[1].workers[0].salary;
         for (const secObj of obj[1].workers) {
            arrOfNames.push(`Name: ${secObj.name} With Salary: ${secObj.salary}`);
         }
      }

      document.getElementById('bestRestaurant').getElementsByTagName('p')[0].textContent = `Name: ${bestName} Average Salary: ${compare.toFixed(2)} Best Salary: ${bestSal.toFixed(2)}`
      document.getElementById('workers').getElementsByTagName('p')[0].textContent = arrOfNames.join(" ");
   }
}