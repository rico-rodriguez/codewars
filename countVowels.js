function getCount(str) {
  let vowels = ['a', 'e', 'i', 'o', 'u'];
  var vowelsCount = 0;
  
  // enter your majic here
  for (let i of str) {
    if (vowels.includes(i)) vowelsCount++;
  }
  
  return vowelsCount;
}
