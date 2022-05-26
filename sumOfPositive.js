function positiveSum(arr) {
let filtered = arr.filter(arr => arr > 0);
let p = filtered.reduce((partialSum, a) => partialSum + a, 0);
return p
}
