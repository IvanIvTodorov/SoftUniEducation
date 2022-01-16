function createSortedList() {
    let sortedList = {
        listOfNums: []
    }
    sortedList.size = sortedList.listOfNums.length;
    sortedList.add = function (number) {
        if (sortedList.listOfNums.length == 0) {
            sortedList.listOfNums.push(number);
        } else {
            for (const num in sortedList.listOfNums) {
                if (number < sortedList.listOfNums[num]) {
                    sortedList.listOfNums.splice(num, 0, number);
                    break;
                }else{
                    if (Number(num) == sortedList.listOfNums.length - 1) {
                        sortedList.listOfNums.push(number);
                    }
                }
            };
        };
        sortedList.size++;
    };
    sortedList.remove = function (index) {
        if (sortedList.listOfNums[index] != undefined) {
            sortedList.size--;
            return Number(sortedList.listOfNums.splice(index, 1));
        }          
    };
    sortedList.get = function (index) {
        return sortedList.listOfNums[index];
    }
    return sortedList;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(4);
list.add(8);
list.add(15);
list.add(11);
list.add(12);
console.log(list.remove(1));
console.log(list.size);
console.log(list.get(1));
