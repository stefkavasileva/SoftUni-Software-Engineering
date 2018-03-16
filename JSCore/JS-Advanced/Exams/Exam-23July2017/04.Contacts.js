class Contact{
    constructor(firstName,lastName,phone,email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
        this.email = email;
        this.element = this.createElement();
        this.online = false;

    }

    set online(value){
        if(value){
          this.element
              .find('.title')
              .addClass('online');
        }else {
            this.element
                .find('.title')
                .removeClass('online');
        }

        this._online = value;
    }

    get online(){
        return this._online;
    }

    render(id){
       $(`#${id}`).append(this.element);
    }

    createElement(){
        let article = $(`<article>`);
        let titleDiv = $(`<div class="title">${this.firstName} ${this.lastName}</div>`);


        let spanPhone = $(`<span>&phone;${this.phone}</span>`);
        let spanEmail = $(`<span>&#9993;${this.email}</span>`);

        let infoDiv = $(`<div class="info" style="display: none"></div>`)
            .append(spanPhone)
            .append(spanEmail);

        let infoBtn = $(`<button>&#8505;</button>`)
            .on('click', () => infoDiv.toggle());

        article.append(titleDiv.append(infoBtn))
            .append(infoDiv);

        return article;
    }
}

let contacts = [
    new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
    new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
    new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
];
contacts.forEach(c => c.render('main'));

// After 1 second, change the online status to true
setTimeout(() => contacts[1].online = true, 2000);
