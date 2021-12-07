import { Component, OnInit } from '@angular/core';
import { decompositionStep } from '../models/decompositionStep';
import { DecompService } from './decomp.service';

@Component({
  selector: 'decomp',
  templateUrl: './decomp.component.html',
  styleUrls: ['./decomp.component.scss']
})
export class DecompComponent implements OnInit {

  numberToDecompose: Number = 0;

  decompSteps: decompositionStep[] | undefined
  decompResume: decompositionStep | undefined

  constructor(private decompService: DecompService) { }

  ngOnInit(): void {
  }

  decomposeNumber() {
    this.decompService.getDecomposition(this.numberToDecompose);
  }
}
