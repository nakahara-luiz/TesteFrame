import { TestBed } from '@angular/core/testing';

import { DecompService } from './decomp.service';

describe('DecompService', () => {
  let service: DecompService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DecompService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
