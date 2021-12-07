import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DecompService {

  private readonly url = "https://localhost:7227/api/decomposition/decompose/{number}";

  constructor(private http: HttpClient) { }

  getDecomposition(numberToDecompose: Number) {
    return this.http.get(this.url.replace("{number}", numberToDecompose.toString()));
  }
}
