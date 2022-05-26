function highAndLow(numbers){
  let sort = numbers.split(' ')
  sort.sort(function(a, b) {return a - b;});

  let splity = sort.splice(-1)
  let firsty = sort[0]
  return (splity +' ' + firsty)
}
