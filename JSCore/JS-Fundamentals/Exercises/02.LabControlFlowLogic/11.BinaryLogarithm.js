function binaryLog(nums) {
    for (let i = 0; i < nums.length; i++) {
        let log = Math.log2(nums[i])
        console.log(log)
    }
}

binaryLog([2,3,4])