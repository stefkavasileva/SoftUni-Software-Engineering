function printLastDay([day,month,year]) {
    let date = new Date(year,month-1,day);
    let currentYear = date.getFullYear();
    let currentMonth = date.getMonth();
    let lastDay = new Date(currentYear, currentMonth, 1, 0);

    console.log(lastDay.getUTCDate());
}

printLastDay([17, 3, 2002]);