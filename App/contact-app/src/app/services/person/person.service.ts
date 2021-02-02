import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

const baseUrl:string = `${environment.apiUrl}/Person/`;

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<any[]>(baseUrl);
  }

  delete(id:number) {
    return this.http.delete(baseUrl+`${id}`)
  }

  getRandomUser(){
    return this.http.get<any[]>('https://randomuser.me/api/?results=100')
  }
}