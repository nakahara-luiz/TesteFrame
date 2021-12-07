import { decompositionStep } from "./decompositionStep"

export interface DecompositionResult {
  DecompositionSteps: decompositionStep[];
  DecompositionResume: decompositionStep
}
