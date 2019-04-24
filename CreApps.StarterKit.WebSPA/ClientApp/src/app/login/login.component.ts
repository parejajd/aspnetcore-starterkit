import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular//common/http'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  // constructor(private provider: HttpProvider) { }

  testRemoteCall(){
    // console.log("click");
    // var data = this.provider.Get<string>("todos");
  }

  ngOnInit() {
  }

}
