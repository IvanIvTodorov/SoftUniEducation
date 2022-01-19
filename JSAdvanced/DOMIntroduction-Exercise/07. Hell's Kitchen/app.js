function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      let input = document.querySelector('textarea').value;
      let splited = input.split(/[\[\"\]]+/g).filter(x => x && x != ',');
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
               salary: workSal
            });
         }
      }
      let compare = 0;
      let bestName = '';
      for (const obj of restaurantCol) {  
      let current = 0;
         for (const arr of obj.workers) {
            
            current += arr.salary;
         }
         if (current > compare) {
            compare = current;
            bestName = obj.restName;
         }
      }
   //.workers.sort((a, b) => a.salary - b.salary);
      // SMetni sus sort kato vzemesh areq ! s best name !!
     
   }
}