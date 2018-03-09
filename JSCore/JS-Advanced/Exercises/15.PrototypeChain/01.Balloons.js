function balloonsClasses() {
    class Balloon{
        constructor(color,gasWeight ){
            this.color = color;
            this.gasWeight = gasWeight;
        }
    }

    class PartyBalloon extends Balloon{
        constructor(color,gasWeight,ribbonColor,ribbonLength){
            super(color,gasWeight);
            this.ribbonColor = ribbonColor;
            this.ribbonLength = ribbonLength;
            this._ribbon = {color:this.ribbonColor, length:this.ribbonLength};
        }

        get ribbon (){
            return this._ribbon;
        }

        set ribbon(value){
            this._ribbon = value;
        }

    }

    class BirthdayBalloon extends  PartyBalloon{
        constructor(color,gasWeight,ribbonColor,ribbonLength,text){
            super(color,gasWeight,ribbonColor,ribbonLength);
            this._text = text;
        }

        get text(){
            return this._text;
        }
    }

    return{Balloon,PartyBalloon,BirthdayBalloon};
}

let balloons = balloonsClasses();
let Balloon = balloons.Balloon;
let PartyBalloon = balloons.PartyBalloon;
let BirthdayBalloon = balloons.BirthdayBalloon;

let balloon = new Balloon('red',1);
let partyBalloon = new PartyBalloon('yellow',1,'blue',2);
let birthdayBalloon = new BirthdayBalloon('orange',1,'yellow',2,'this is a birthday balloon');

console.log(balloons);
console.log(partyBalloon);
console.log(birthdayBalloon);