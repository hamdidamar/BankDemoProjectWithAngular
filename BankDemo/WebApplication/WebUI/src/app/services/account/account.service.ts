import { Injectable } from '@angular/core'
import { HttpClient, HttpParams } from '@angular/common/http'

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  constructor(private http: HttpClient) {}

  url = 'https://localhost:44312/' // api portu bilgisayara göre değişklik gösterebilir

  getAllByUserId(userId: any) {
  
    let accountParams = new HttpParams().set("userId",userId);

    return this.http.get(this.url+'api/account', {params: accountParams}); 
    
  }
}
