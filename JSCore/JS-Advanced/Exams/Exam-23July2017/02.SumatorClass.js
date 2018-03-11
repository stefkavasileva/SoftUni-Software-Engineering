class Sumator {
    constructor() {
        this.data = [];
    }
    add(item) {
        this.data.push(item);
    }
    sumNums() {
        let sum = 0;
        for (let item of this.data)
            if (typeof (item) === 'number')
                sum += item;
        return sum;
    }
    removeByFilter(filterFunc) {
        this.data = this.data.filter(x => !filterFunc(x));
    }
    toString() {
        if (this.data.length > 0)
            return this.data.join(", ");
        else
            return '(empty)';
    }
}

module.exports = Sumator;