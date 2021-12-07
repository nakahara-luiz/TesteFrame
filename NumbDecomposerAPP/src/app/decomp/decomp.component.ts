import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { DecompositionResult } from '../models/decompositionResult';
import { decompositionStep } from '../models/decompositionStep';
import { DecompService } from './decomp.service';

@Component({
  selector: 'decomp',
  templateUrl: './decomp.component.html',
  styleUrls: ['./decomp.component.scss']
})
export class DecompComponent implements OnInit {

  numberToDecompose: Number | undefined;

  decompResult: DecompositionResult | undefined;

  constructor(private decompService: DecompService,
              translate: TranslateService) { }

  ngOnInit(): void {
  }

  decomposeNumber() {
    if (this.numberToDecompose === undefined) return;

    this.decompService.getDecomposition(this.numberToDecompose).subscribe(response => {
      this.decompResult = response;
    }, error => {
      console.log(error);
      alert(error.message);
    });
  }
}
