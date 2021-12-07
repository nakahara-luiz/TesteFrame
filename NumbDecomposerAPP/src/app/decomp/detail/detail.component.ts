import { Component, Input, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { decompositionStep } from 'src/app/models/decompositionStep';

@Component({
  selector: 'decomp-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.scss']
})
export class DetailComponent implements OnInit {

  @Input() decompSteps: decompositionStep[] | undefined
  @Input() decompResume: decompositionStep | undefined

  constructor(translate: TranslateService) { }

  ngOnInit(): void {
  }
}
