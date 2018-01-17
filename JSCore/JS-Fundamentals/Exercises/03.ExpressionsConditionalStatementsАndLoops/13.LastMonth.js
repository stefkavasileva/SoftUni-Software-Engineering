function printLastDay([day,month,year]) {
    let date = new Date(year,month-1,day);
    let curentYear = date.getFullYear();
    let curentMonth = date.getMonth();
    let lastDay = new Date(curentYear, curentMonth, 1, 0);

    console.log(lastDay.getUTCDate());
}

printLastDay([17, 3, 2002]);