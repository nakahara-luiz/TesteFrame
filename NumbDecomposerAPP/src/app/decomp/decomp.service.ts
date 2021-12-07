import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DecompositionResult } from '../models/decompositionResult';

@Injectable({
  providedIn: 'root'
})
export class DecompService {

  private readonly url = "http://localhost:7227/api/decomposition/decompose/{number}";

  constructor(private http: HttpClient) { }

  getDecomposition(numberToDecompose: Number): Observable<DecompositionResult>{
    return this.http.get<DecompositionResult>(this.url.replace("{number}", numberToDecompose.toString()));
  }
}
