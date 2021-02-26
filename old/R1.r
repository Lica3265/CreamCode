# Q1.
pbad=0.17
pgood=0.83
pbad_accept=0.1
pbad_reject=0.9
pgood_accept=0.95
pgood_reject=0.05
runs=1000
daily_check_quantity=20*8*50

dailyChips=function(){
  daily_good_quantity=rbinom(1,daily_check_quantity,pgood)
  daily_bad_quantity=daily_check_quantity-daily_good_quantity
  daily_good_quantity_accepted=rbinom(1,daily_good_quantity,pgood_accept)
  daily_bad_quantity_accepted=rbinom(1,daily_bad_quantity,pbad_accept)
  daily_delivered_quantity=daily_good_quantity_accepted+daily_bad_quantity_accepted
  daily_good_ratio=daily_good_quantity_accepted/daily_delivered_quantity

  c(daily_delivered_quantity, daily_good_ratio)
}

target=replicate(runs,dailyChips())
#(a)
sum(target[2,]>0.98)/runs
#(b)
sum(target[1,]>6400)/runs