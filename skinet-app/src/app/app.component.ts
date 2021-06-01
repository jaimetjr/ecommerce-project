import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IPagination } from './models/pagination';
import { IProduct } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'skinet-app';
  products: IProduct[];

  constructor(private httpClient: HttpClient) {

  }

  ngOnInit(): void {
    this.httpClient.get('https://localhost:44311/api/products').subscribe((res : IPagination) => {
      this.products = res.data;
    }, error => {
      console.log(error);
    });
  }
}
