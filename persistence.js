function persistence(num) {
  var result = 0;
  var numStr = num.toString();
  while (numStr.length > 1) {
    result++;
    numStr = numStr
      .split('')
      .map(Number)
      .reduce(function (a, b) {
        return a * b;
      })
      .toString();
  }
  return result;
}
