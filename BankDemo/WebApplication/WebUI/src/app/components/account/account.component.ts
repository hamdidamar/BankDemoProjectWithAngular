import { Component, OnInit } from '@angular/core'
import { AccountService } from 'src/app/services/account/account.service'

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.scss'],
})
export class AccountComponent implements OnInit {
  constructor(private accountService: AccountService) {}

  items: any
  ngOnInit(): void {
    this.accountService.getAllByUserId(1).subscribe((data) => { // default olarak user id 1 yolluyorum. buraya giriş yapanın idsi gelebilir
      console.log(data)
      this.items = data
    })
  }
}
