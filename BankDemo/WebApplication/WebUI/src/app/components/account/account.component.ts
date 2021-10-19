import { Component, OnInit } from '@angular/core'
import { Router } from '@angular/router'
import { AccountService } from 'src/app/services/account/account.service'

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.scss'],
})
export class AccountComponent implements OnInit {
  constructor(private accountService: AccountService,private router:Router) {}

  items: any
  ngOnInit(): void {
    this.accountService.getAllByUserId(1).subscribe((data) => { // default olarak user id 1 yolluyorum. buraya giriş yapanın idsi gelebilir
      console.log(data)
      this.items = data
    })
  }

  addMoney(item:any){
    this.router.navigate(['addMoney',JSON.stringify(item)])
  }

  takeMoney(item:any){
    this.router.navigate(['takeMoney',JSON.stringify(item)])
  }
}


