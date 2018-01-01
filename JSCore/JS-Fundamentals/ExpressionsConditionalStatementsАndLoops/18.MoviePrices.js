function getTicketPrice([movieTitle, dayOfWeek]) {
    let price = 0;
    movieTitle = movieTitle.toLowerCase();
    dayOfWeek = dayOfWeek.toLowerCase();

    if(movieTitle == "the godfather"){
        switch(dayOfWeek){
            case "monday":
                price = 12;
                break;
            case "tuesday":
                price = 10;
                break;
            case "wednesday":
            case "friday" :
                price = 15;
                break;
            case "thursday":
                price = 12.5;
                break;
            case "saturday":
                price = 25;
                break;
            case "sunday":
                price = 30;
                break;
            default : price= "error";
                break;
        }
    }else if(movieTitle == "schindler's list"){
            switch(dayOfWeek){
            case "monday":
            case "tuesday":
            case "wednesday":
            case "friday" :
            case "thursday":
                price = 8.5;
                break;
            case "saturday":
            case "sunday":
                price = 15;
                break;
            default : price = "error";
                break;
            }
    }
    else if(movieTitle == "casablanca"){
        switch(dayOfWeek){
            case "monday":
            case "tuesday":
            case "wednesday":
            case "friday" :
            case "thursday":
                price = 8;
                break;
            case "saturday":
            case "sunday":
                price = 10;
                break;
            default : price = "error";
                break;
        }
    }else if(movieTitle == "the wizard of oz"){
        switch(dayOfWeek){
            case "monday":
            case "tuesday":
            case "wednesday":
            case "friday" :
            case "thursday":
                price = 10;
                break;
            case "saturday":
            case "sunday":
                price = 15;
                break;
            default : price = "error";
                break;
        }
    }else {
        price = "error";
    }

    console.log(price);
}

getTicketPrice(["schindler's list", "Thursday"]);