function bmi(weight, height) {
  let i
  i = weight / (height*height)
 return i <= 18.5 ? 'Underweight' : i <= 25.0 ? 'Normal' : i <= 30 ? "Overweight" : "Obese"
}
